using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Nesillas;

/// <summary>
/// Abstract class for Nesillas (genus).
/// NCBI TaxId: 552921
/// </summary>
public abstract class Nesillas : Sylviidae, INesillas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesillas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 552921;

    /// <inheritdoc />
    public virtual string GenusName => "Nesillas";

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
