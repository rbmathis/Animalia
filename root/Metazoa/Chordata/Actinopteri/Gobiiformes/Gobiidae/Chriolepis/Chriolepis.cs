using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Chriolepis;

/// <summary>
/// Abstract class for Chriolepis (genus).
/// NCBI TaxId: 203287
/// </summary>
public abstract class Chriolepis : Gobiidae, IChriolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chriolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203287;

    /// <inheritdoc />
    public virtual string GenusName => "Chriolepis";

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
