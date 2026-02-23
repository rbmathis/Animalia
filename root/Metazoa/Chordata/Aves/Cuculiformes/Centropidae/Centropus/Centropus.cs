using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Centropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Centropidae.Centropus;

/// <summary>
/// Abstract class for Centropus (genus).
/// NCBI TaxId: 57401
/// </summary>
public abstract class Centropus : Centropidae, ICentropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57401;

    /// <inheritdoc />
    public virtual string GenusName => "Centropus";

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
