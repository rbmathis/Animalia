using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae.Calyptocephallela;

/// <summary>
/// Abstract class for Calyptocephallela (genus).
/// NCBI TaxId: 613087
/// </summary>
public abstract class Calyptocephallela : Calyptocephalellidae, ICalyptocephallela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptocephallela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613087;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptocephallela";

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
