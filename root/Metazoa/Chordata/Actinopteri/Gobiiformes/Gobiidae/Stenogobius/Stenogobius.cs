using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stenogobius;

/// <summary>
/// Abstract class for Stenogobius (genus).
/// NCBI TaxId: 70079
/// </summary>
public abstract class Stenogobius : Gobiidae, IStenogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70079;

    /// <inheritdoc />
    public virtual string GenusName => "Stenogobius";

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
