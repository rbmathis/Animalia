using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Distoechodon;

/// <summary>
/// Abstract class for Distoechodon (genus).
/// NCBI TaxId: 70102
/// </summary>
public abstract class Distoechodon : Xenocyprididae, IDistoechodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distoechodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70102;

    /// <inheritdoc />
    public virtual string GenusName => "Distoechodon";

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
