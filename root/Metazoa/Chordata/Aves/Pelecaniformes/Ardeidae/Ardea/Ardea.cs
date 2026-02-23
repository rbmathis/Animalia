using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardea;

/// <summary>
/// Abstract class for Ardea (genus).
/// NCBI TaxId: 30389
/// </summary>
public abstract class Ardea : Ardeidae, IArdea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ardea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30389;

    /// <inheritdoc />
    public virtual string GenusName => "Ardea";

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
