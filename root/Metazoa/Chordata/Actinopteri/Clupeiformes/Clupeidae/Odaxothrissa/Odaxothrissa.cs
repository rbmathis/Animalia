using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Odaxothrissa;

/// <summary>
/// Abstract class for Odaxothrissa (genus).
/// NCBI TaxId: 402403
/// </summary>
public abstract class Odaxothrissa : Clupeidae, IOdaxothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odaxothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 402403;

    /// <inheritdoc />
    public virtual string GenusName => "Odaxothrissa";

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
