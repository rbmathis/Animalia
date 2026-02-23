using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Botaurus;

/// <summary>
/// Abstract class for Botaurus (genus).
/// NCBI TaxId: 110660
/// </summary>
public abstract class Botaurus : Ardeidae, IBotaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Botaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110660;

    /// <inheritdoc />
    public virtual string GenusName => "Botaurus";

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
