using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae.Vidua;

/// <summary>
/// Abstract class for Vidua (genus).
/// NCBI TaxId: 37613
/// </summary>
public abstract class Vidua : Viduidae, IVidua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vidua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37613;

    /// <inheritdoc />
    public virtual string GenusName => "Vidua";

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
