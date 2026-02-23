using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Monachella;

/// <summary>
/// Abstract class for Monachella (genus).
/// NCBI TaxId: 1080468
/// </summary>
public abstract class Monachella : Petroicidae, IMonachella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monachella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1080468;

    /// <inheritdoc />
    public virtual string GenusName => "Monachella";

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
