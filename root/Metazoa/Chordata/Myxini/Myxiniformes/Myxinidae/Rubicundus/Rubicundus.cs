using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Rubicundus;

/// <summary>
/// Abstract class for Rubicundus (genus).
/// NCBI TaxId: 1315019
/// </summary>
public abstract class Rubicundus : Myxinidae, IRubicundus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rubicundus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315019;

    /// <inheritdoc />
    public virtual string GenusName => "Rubicundus";

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
