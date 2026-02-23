using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae.Chloroceryle;

/// <summary>
/// Abstract class for Chloroceryle (genus).
/// NCBI TaxId: 57405
/// </summary>
public abstract class Chloroceryle : Cerylidae, IChloroceryle
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloroceryle";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57405;

    /// <inheritdoc />
    public virtual string GenusName => "Chloroceryle";

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
