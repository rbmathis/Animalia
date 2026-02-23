using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Polyipnus;

/// <summary>
/// Abstract class for Polyipnus (genus).
/// NCBI TaxId: 81871
/// </summary>
public abstract class Polyipnus : Sternoptychidae, IPolyipnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyipnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81871;

    /// <inheritdoc />
    public virtual string GenusName => "Polyipnus";

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
