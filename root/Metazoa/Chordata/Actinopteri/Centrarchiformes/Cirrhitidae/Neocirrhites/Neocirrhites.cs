using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Neocirrhites;

/// <summary>
/// Abstract class for Neocirrhites (genus).
/// NCBI TaxId: 587056
/// </summary>
public abstract class Neocirrhites : Cirrhitidae, INeocirrhites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocirrhites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587056;

    /// <inheritdoc />
    public virtual string GenusName => "Neocirrhites";

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
