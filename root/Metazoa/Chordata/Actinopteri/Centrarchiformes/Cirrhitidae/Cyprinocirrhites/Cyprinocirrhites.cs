using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cyprinocirrhites;

/// <summary>
/// Abstract class for Cyprinocirrhites (genus).
/// NCBI TaxId: 1003945
/// </summary>
public abstract class Cyprinocirrhites : Cirrhitidae, ICyprinocirrhites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinocirrhites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003945;

    /// <inheritdoc />
    public virtual string GenusName => "Cyprinocirrhites";

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
