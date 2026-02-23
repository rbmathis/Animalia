using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Platygobio;

/// <summary>
/// Abstract class for Platygobio (genus).
/// NCBI TaxId: 67553
/// </summary>
public abstract class Platygobio : Leuciscidae, IPlatygobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platygobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67553;

    /// <inheritdoc />
    public virtual string GenusName => "Platygobio";

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
