using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Oreostruthus;

/// <summary>
/// Abstract class for Oreostruthus (genus).
/// NCBI TaxId: 2715629
/// </summary>
public abstract class Oreostruthus : Estrildidae, IOreostruthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreostruthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715629;

    /// <inheritdoc />
    public virtual string GenusName => "Oreostruthus";

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
