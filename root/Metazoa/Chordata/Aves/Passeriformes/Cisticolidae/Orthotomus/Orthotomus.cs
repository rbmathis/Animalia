using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Orthotomus;

/// <summary>
/// Abstract class for Orthotomus (genus).
/// NCBI TaxId: 546339
/// </summary>
public abstract class Orthotomus : Cisticolidae, IOrthotomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthotomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 546339;

    /// <inheritdoc />
    public virtual string GenusName => "Orthotomus";

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
