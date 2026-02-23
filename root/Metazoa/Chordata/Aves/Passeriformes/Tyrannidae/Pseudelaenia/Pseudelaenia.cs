using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pseudelaenia;

/// <summary>
/// Abstract class for Pseudelaenia (genus).
/// NCBI TaxId: 649815
/// </summary>
public abstract class Pseudelaenia : Tyrannidae, IPseudelaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudelaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649815;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudelaenia";

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
