using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Pachycephalopsis;

/// <summary>
/// Abstract class for Pachycephalopsis (genus).
/// NCBI TaxId: 254570
/// </summary>
public abstract class Pachycephalopsis : Petroicidae, IPachycephalopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycephalopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254570;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycephalopsis";

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
