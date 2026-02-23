using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Acanthochromis;

/// <summary>
/// Abstract class for Acanthochromis (genus).
/// NCBI TaxId: 80965
/// </summary>
public abstract class Acanthochromis : Pomacentridae, IAcanthochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80965;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthochromis";

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
