using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Plagiognathops;

/// <summary>
/// Abstract class for Plagiognathops (genus).
/// NCBI TaxId: 927612
/// </summary>
public abstract class Plagiognathops : Xenocyprididae, IPlagiognathops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagiognathops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 927612;

    /// <inheritdoc />
    public virtual string GenusName => "Plagiognathops";

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
