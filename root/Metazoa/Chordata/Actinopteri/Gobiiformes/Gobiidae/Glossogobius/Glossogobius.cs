using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Glossogobius;

/// <summary>
/// Abstract class for Glossogobius (genus).
/// NCBI TaxId: 150297
/// </summary>
public abstract class Glossogobius : Gobiidae, IGlossogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150297;

    /// <inheritdoc />
    public virtual string GenusName => "Glossogobius";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
