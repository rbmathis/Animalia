using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ptyctolaemus;

/// <summary>
/// Abstract class for Ptyctolaemus (genus).
/// NCBI TaxId: 89033
/// </summary>
public abstract class Ptyctolaemus : Agamidae, IPtyctolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptyctolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89033;

    /// <inheritdoc />
    public virtual string GenusName => "Ptyctolaemus";

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
