using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitops;

/// <summary>
/// Abstract class for Cirrhitops (genus).
/// NCBI TaxId: 529472
/// </summary>
public abstract class Cirrhitops : Cirrhitidae, ICirrhitops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhitops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529472;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhitops";

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
