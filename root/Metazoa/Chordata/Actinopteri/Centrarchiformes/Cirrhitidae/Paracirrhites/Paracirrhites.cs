using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Paracirrhites;

/// <summary>
/// Abstract class for Paracirrhites (genus).
/// NCBI TaxId: 100205
/// </summary>
public abstract class Paracirrhites : Cirrhitidae, IParacirrhites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracirrhites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100205;

    /// <inheritdoc />
    public virtual string GenusName => "Paracirrhites";

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
