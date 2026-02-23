using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Conostoma;

/// <summary>
/// Abstract class for Conostoma (genus).
/// NCBI TaxId: 1071681
/// </summary>
public abstract class Conostoma : Timaliidae, IConostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1071681;

    /// <inheritdoc />
    public virtual string GenusName => "Conostoma";

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
