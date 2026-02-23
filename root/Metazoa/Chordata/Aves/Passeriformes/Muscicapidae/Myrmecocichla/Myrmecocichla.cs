using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Myrmecocichla;

/// <summary>
/// Abstract class for Myrmecocichla (genus).
/// NCBI TaxId: 701079
/// </summary>
public abstract class Myrmecocichla : Muscicapidae, IMyrmecocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmecocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 701079;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmecocichla";

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
