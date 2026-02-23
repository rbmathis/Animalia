using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Nexilosus;

/// <summary>
/// Abstract class for Nexilosus (genus).
/// NCBI TaxId: 646046
/// </summary>
public abstract class Nexilosus : Pomacentridae, INexilosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nexilosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646046;

    /// <inheritdoc />
    public virtual string GenusName => "Nexilosus";

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
