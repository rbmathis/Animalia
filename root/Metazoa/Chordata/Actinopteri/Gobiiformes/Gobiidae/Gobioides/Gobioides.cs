using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobioides;

/// <summary>
/// Abstract class for Gobioides (genus).
/// NCBI TaxId: 1046120
/// </summary>
public abstract class Gobioides : Gobiidae, IGobioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1046120;

    /// <inheritdoc />
    public virtual string GenusName => "Gobioides";

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
