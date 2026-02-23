using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus.Labeobarbus_megastoma_complex;

/// <summary>
/// Abstract class for Labeobarbus megastoma complex (no rank).
/// NCBI TaxId: 3455215
/// </summary>
public abstract class Labeobarbus_megastoma_complex : Labeobarbus, ILabeobarbus_megastoma_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labeobarbus megastoma complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3455215;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Labeobarbus_megastoma_complex";
}
