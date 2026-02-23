using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Cistothorus;

/// <summary>
/// Abstract class for Cistothorus (genus).
/// NCBI TaxId: 241530
/// </summary>
public abstract class Cistothorus : Certhiidae, ICistothorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cistothorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241530;

    /// <inheritdoc />
    public virtual string GenusName => "Cistothorus";

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
