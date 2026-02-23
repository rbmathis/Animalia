using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Chlorospingus;

/// <summary>
/// Abstract class for Chlorospingus (genus).
/// NCBI TaxId: 62170
/// </summary>
public abstract class Chlorospingus : Passerellidae, IChlorospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62170;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorospingus";

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
