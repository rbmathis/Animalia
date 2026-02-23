using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Nesocichla;

/// <summary>
/// Abstract class for Nesocichla (genus).
/// NCBI TaxId: 311367
/// </summary>
public abstract class Nesocichla : Muscicapidae, INesocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311367;

    /// <inheritdoc />
    public virtual string GenusName => "Nesocichla";

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
