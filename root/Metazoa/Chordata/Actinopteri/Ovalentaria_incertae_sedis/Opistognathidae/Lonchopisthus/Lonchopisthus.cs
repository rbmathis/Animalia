using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Lonchopisthus;

/// <summary>
/// Abstract class for Lonchopisthus (genus).
/// NCBI TaxId: 1311554
/// </summary>
public abstract class Lonchopisthus : Opistognathidae, ILonchopisthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchopisthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311554;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchopisthus";

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
