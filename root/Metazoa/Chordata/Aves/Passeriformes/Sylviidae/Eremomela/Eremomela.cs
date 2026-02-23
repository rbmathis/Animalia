using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Eremomela;

/// <summary>
/// Abstract class for Eremomela (genus).
/// NCBI TaxId: 552898
/// </summary>
public abstract class Eremomela : Sylviidae, IEremomela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremomela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 552898;

    /// <inheritdoc />
    public virtual string GenusName => "Eremomela";

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
