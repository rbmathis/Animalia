using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chionomesa;

/// <summary>
/// Abstract class for Chionomesa (genus).
/// NCBI TaxId: 3018373
/// </summary>
public abstract class Chionomesa : Trochilidae, IChionomesa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chionomesa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3018373;

    /// <inheritdoc />
    public virtual string GenusName => "Chionomesa";

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
