using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Gennaeodryas;

/// <summary>
/// Abstract class for Gennaeodryas (genus).
/// NCBI TaxId: 3108817
/// </summary>
public abstract class Gennaeodryas : Petroicidae, IGennaeodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gennaeodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3108817;

    /// <inheritdoc />
    public virtual string GenusName => "Gennaeodryas";

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
