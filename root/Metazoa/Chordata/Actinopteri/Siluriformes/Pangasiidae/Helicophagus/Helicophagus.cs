using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Helicophagus;

/// <summary>
/// Abstract class for Helicophagus (genus).
/// NCBI TaxId: 337760
/// </summary>
public abstract class Helicophagus : Pangasiidae, IHelicophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helicophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337760;

    /// <inheritdoc />
    public virtual string GenusName => "Helicophagus";

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
