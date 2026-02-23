using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Leuroglossus;

/// <summary>
/// Abstract class for Leuroglossus (genus).
/// NCBI TaxId: 182445
/// </summary>
public abstract class Leuroglossus : Bathylagidae, ILeuroglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leuroglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182445;

    /// <inheritdoc />
    public virtual string GenusName => "Leuroglossus";

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
