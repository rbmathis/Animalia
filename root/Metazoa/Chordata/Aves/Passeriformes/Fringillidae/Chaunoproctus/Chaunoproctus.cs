using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chaunoproctus;

/// <summary>
/// Abstract class for Chaunoproctus (genus).
/// NCBI TaxId: 1105358
/// </summary>
public abstract class Chaunoproctus : Fringillidae, IChaunoproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaunoproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1105358;

    /// <inheritdoc />
    public virtual string GenusName => "Chaunoproctus";

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
