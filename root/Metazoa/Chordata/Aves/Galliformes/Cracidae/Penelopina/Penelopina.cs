using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelopina;

/// <summary>
/// Abstract class for Penelopina (genus).
/// NCBI TaxId: 116995
/// </summary>
public abstract class Penelopina : Cracidae, IPenelopina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Penelopina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 116995;

    /// <inheritdoc />
    public virtual string GenusName => "Penelopina";

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
