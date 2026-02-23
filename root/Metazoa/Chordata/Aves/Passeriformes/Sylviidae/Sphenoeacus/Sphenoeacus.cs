using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sphenoeacus;

/// <summary>
/// Abstract class for Sphenoeacus (genus).
/// NCBI TaxId: 315550
/// </summary>
public abstract class Sphenoeacus : Sylviidae, ISphenoeacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenoeacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315550;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenoeacus";

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
