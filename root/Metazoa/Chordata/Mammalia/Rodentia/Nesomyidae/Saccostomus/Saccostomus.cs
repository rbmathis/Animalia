using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Saccostomus;

/// <summary>
/// Abstract class for Saccostomus (genus).
/// NCBI TaxId: 106346
/// </summary>
public abstract class Saccostomus : Nesomyidae, ISaccostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106346;

    /// <inheritdoc />
    public virtual string GenusName => "Saccostomus";

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
