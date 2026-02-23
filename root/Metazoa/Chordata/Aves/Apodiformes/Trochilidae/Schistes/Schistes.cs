using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Schistes;

/// <summary>
/// Abstract class for Schistes (genus).
/// NCBI TaxId: 304683
/// </summary>
public abstract class Schistes : Trochilidae, ISchistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304683;

    /// <inheritdoc />
    public virtual string GenusName => "Schistes";

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
