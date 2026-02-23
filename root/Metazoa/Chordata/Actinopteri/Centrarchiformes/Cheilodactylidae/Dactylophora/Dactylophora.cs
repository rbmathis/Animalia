using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Dactylophora;

/// <summary>
/// Abstract class for Dactylophora (genus).
/// NCBI TaxId: 76924
/// </summary>
public abstract class Dactylophora : Cheilodactylidae, IDactylophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76924;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylophora";

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
