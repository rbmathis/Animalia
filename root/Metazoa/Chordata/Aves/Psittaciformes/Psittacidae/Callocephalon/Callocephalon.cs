using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Callocephalon;

/// <summary>
/// Abstract class for Callocephalon (genus).
/// NCBI TaxId: 986100
/// </summary>
public abstract class Callocephalon : Psittacidae, ICallocephalon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callocephalon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 986100;

    /// <inheritdoc />
    public virtual string GenusName => "Callocephalon";

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
