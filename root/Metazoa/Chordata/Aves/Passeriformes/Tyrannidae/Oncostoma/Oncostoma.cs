using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Oncostoma;

/// <summary>
/// Abstract class for Oncostoma (genus).
/// NCBI TaxId: 360221
/// </summary>
public abstract class Oncostoma : Tyrannidae, IOncostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oncostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360221;

    /// <inheritdoc />
    public virtual string GenusName => "Oncostoma";

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
