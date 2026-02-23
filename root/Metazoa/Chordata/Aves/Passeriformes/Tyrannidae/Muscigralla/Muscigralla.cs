using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscigralla;

/// <summary>
/// Abstract class for Muscigralla (genus).
/// NCBI TaxId: 123644
/// </summary>
public abstract class Muscigralla : Tyrannidae, IMuscigralla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muscigralla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123644;

    /// <inheritdoc />
    public virtual string GenusName => "Muscigralla";

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
