using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitichthys;

/// <summary>
/// Abstract class for Cirrhitichthys (genus).
/// NCBI TaxId: 215369
/// </summary>
public abstract class Cirrhitichthys : Cirrhitidae, ICirrhitichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhitichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215369;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhitichthys";

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
