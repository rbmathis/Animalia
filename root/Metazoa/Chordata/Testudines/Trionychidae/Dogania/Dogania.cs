using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Dogania;

/// <summary>
/// Abstract class for Dogania (genus).
/// NCBI TaxId: 159309
/// </summary>
public abstract class Dogania : Trionychidae, IDogania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dogania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159309;

    /// <inheritdoc />
    public virtual string GenusName => "Dogania";

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
