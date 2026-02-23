using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Actitis;

/// <summary>
/// Abstract class for Actitis (genus).
/// NCBI TaxId: 190658
/// </summary>
public abstract class Actitis : Scolopacidae, IActitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Actitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190658;

    /// <inheritdoc />
    public virtual string GenusName => "Actitis";

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
