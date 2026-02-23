using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Premnoplex;

/// <summary>
/// Abstract class for Premnoplex (genus).
/// NCBI TaxId: 329505
/// </summary>
public abstract class Premnoplex : Furnariidae, IPremnoplex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Premnoplex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329505;

    /// <inheritdoc />
    public virtual string GenusName => "Premnoplex";

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
