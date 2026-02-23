using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Paedocypris;

/// <summary>
/// Abstract class for Paedocypris (genus).
/// NCBI TaxId: 432420
/// </summary>
public abstract class Paedocypris : Cypriniformes, IPaedocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paedocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432420;

    /// <inheritdoc />
    public virtual string GenusName => "Paedocypris";

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
