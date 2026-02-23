using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Afropavo;

/// <summary>
/// Abstract class for Afropavo (genus).
/// NCBI TaxId: 9075
/// </summary>
public abstract class Afropavo : Phasianidae, IAfropavo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afropavo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9075;

    /// <inheritdoc />
    public virtual string GenusName => "Afropavo";

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
