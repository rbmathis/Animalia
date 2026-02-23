using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Elaenia;

/// <summary>
/// Abstract class for Elaenia (genus).
/// NCBI TaxId: 111982
/// </summary>
public abstract class Elaenia : Tyrannidae, IElaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111982;

    /// <inheritdoc />
    public virtual string GenusName => "Elaenia";

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
