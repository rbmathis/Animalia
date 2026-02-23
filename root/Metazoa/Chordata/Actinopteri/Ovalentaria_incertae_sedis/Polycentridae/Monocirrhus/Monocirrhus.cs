using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Monocirrhus;

/// <summary>
/// Abstract class for Monocirrhus (genus).
/// NCBI TaxId: 302771
/// </summary>
public abstract class Monocirrhus : Polycentridae, IMonocirrhus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monocirrhus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302771;

    /// <inheritdoc />
    public virtual string GenusName => "Monocirrhus";

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
