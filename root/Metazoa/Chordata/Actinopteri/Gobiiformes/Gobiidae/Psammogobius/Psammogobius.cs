using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Psammogobius;

/// <summary>
/// Abstract class for Psammogobius (genus).
/// NCBI TaxId: 508058
/// </summary>
public abstract class Psammogobius : Gobiidae, IPsammogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 508058;

    /// <inheritdoc />
    public virtual string GenusName => "Psammogobius";

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
