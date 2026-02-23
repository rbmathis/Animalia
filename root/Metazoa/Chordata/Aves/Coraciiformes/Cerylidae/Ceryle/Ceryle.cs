using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae.Ceryle;

/// <summary>
/// Abstract class for Ceryle (genus).
/// NCBI TaxId: 176939
/// </summary>
public abstract class Ceryle : Cerylidae, ICeryle
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceryle";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176939;

    /// <inheritdoc />
    public virtual string GenusName => "Ceryle";

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
