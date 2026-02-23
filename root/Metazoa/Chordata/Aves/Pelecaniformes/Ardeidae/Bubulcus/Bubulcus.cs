using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Bubulcus;

/// <summary>
/// Abstract class for Bubulcus (genus).
/// NCBI TaxId: 110667
/// </summary>
public abstract class Bubulcus : Ardeidae, IBubulcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bubulcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110667;

    /// <inheritdoc />
    public virtual string GenusName => "Bubulcus";

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
