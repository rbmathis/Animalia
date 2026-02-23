using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Pomatostomus;

/// <summary>
/// Abstract class for Pomatostomus (genus).
/// NCBI TaxId: 9174
/// </summary>
public abstract class Pomatostomus : Timaliidae, IPomatostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomatostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9174;

    /// <inheritdoc />
    public virtual string GenusName => "Pomatostomus";

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
